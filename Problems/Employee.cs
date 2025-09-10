namespace Problems
{
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// This method does the default sorting on employee . If the IComparable interface is not implemented the default Sort operation on the Employee list will throw exception.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Employee? other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
