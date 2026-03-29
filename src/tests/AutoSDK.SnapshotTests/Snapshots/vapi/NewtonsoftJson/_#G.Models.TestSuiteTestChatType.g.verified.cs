//HintName: G.Models.TestSuiteTestChatType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the test, which must be chat.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TestSuiteTestChatType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chat")]
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteTestChatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteTestChatType value)
        {
            return value switch
            {
                TestSuiteTestChatType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteTestChatType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => TestSuiteTestChatType.Chat,
                _ => null,
            };
        }
    }
}