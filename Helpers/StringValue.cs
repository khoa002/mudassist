namespace Mud.Helpers
{
    public class StringValue
    {
        public StringValue(string s)
        {
            Name = s;
        }

        public StringValue()
        {
            Name = "";
        }

        public string Name { get; set; }
    }
}