//HintName: G.Models.UpdateTestSuiteTestChatDtoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the test, which must be chat.
    /// </summary>
    public enum UpdateTestSuiteTestChatDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Chat,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTestSuiteTestChatDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTestSuiteTestChatDtoType value)
        {
            return value switch
            {
                UpdateTestSuiteTestChatDtoType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTestSuiteTestChatDtoType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => UpdateTestSuiteTestChatDtoType.Chat,
                _ => null,
            };
        }
    }
}