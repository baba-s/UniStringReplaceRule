namespace Kogane
{
	public readonly struct StringReplaceRule
	{
		public string OldValue { get; }
		public string NewValue { get; }

		public StringReplaceRule( string oldValue, string newValue )
		{
			OldValue = oldValue;
			NewValue = newValue;
		}
	}

	public static class StringExt
	{
		public static string Replace( this string self, StringReplaceRule rule )
		{
			return self.Replace( rule.OldValue, rule.NewValue );
		}
	}
}