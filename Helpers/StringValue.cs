namespace Mud.Helpers
{
	public class StringValue
	{
		private string _value;

		public StringValue(string s)
		{
			_value = s;
		}

		public StringValue()
		{
			_value = "";
		}

		public string Name { get { return _value; } set { _value = value; } }
	}
}