namespace Event.Sample
{
    public class Publisher
    {
        // Step 1: Declare the event
        public event EventHandler SomethingHappened;

        public void DoWork()
        {
            Console.WriteLine("Publisher: Doing work...");

            // Step 2: Raise the event
            OnSomethingHappened();
        }

        protected virtual void OnSomethingHappened()
        {
            // Step 3: Invoke event (notify subscribers)
            SomethingHappened?.Invoke(this, EventArgs.Empty);
        }
    }

    public class Subscriber
    {
        // Step 4: Define event handler
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Subscriber: I got notified!");
        }
    }
    // Step 1: Create custom EventArgs
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; }
        public MessageEventArgs(string message) => Message = message;
    }

    public class PublisherWithMessage
    {
        // Step 2: Declare event with custom EventArgs
        public event EventHandler<MessageEventArgs> MessageReceived;

        public void SendMessage(string message)
        {
            Console.WriteLine("Publisher: Sending message...");
            OnMessageReceived(new MessageEventArgs(message));
        }

        protected virtual void OnMessageReceived(MessageEventArgs e)
        {
            // Step 3: Raise event with data
            MessageReceived?.Invoke(this, e);
        }
    }

    public class SubscriberWithMessage
    {
        // Step 4: Event handler that reads the data
        public void OnMessageReceived(object sender, MessageEventArgs e)
        {
            Console.WriteLine($"Subscriber: Got message = {e.Message}");
        }
    }

    partial class Program
    {
        static void Main()
        {
            var publisher = new Publisher();
            var subscriber = new Subscriber();

            // Step 5: Subscribe to the event
            publisher.SomethingHappened += subscriber.HandleEvent;

            // Step 6: Trigger work
            publisher.DoWork();

            var publisherWithMessage = new PublisherWithMessage();
            var subscriberWithMessage = new SubscriberWithMessage();

            // Subscribe
            publisherWithMessage.MessageReceived += subscriberWithMessage.OnMessageReceived;

            // Trigger event
            publisherWithMessage.SendMessage("Hello from .NET Core!");
        }
    }

}





