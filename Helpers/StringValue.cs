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

        private string Name { get; }
    }
}