//HintName: G.Models.CreateTestSuiteTestChatDtoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the test, which must be chat.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTestSuiteTestChatDtoType
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
    public static class CreateTestSuiteTestChatDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTestSuiteTestChatDtoType value)
        {
            return value switch
            {
                CreateTestSuiteTestChatDtoType.Chat => "chat",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTestSuiteTestChatDtoType? ToEnum(string value)
        {
            return value switch
            {
                "chat" => CreateTestSuiteTestChatDtoType.Chat,
                _ => null,
            };
        }
    }
}