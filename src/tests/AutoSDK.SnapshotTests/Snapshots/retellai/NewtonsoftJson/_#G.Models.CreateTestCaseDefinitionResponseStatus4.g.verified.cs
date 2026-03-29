//HintName: G.Models.CreateTestCaseDefinitionResponseStatus4.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTestCaseDefinitionResponseStatus4
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="error")]
        Error,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTestCaseDefinitionResponseStatus4Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTestCaseDefinitionResponseStatus4 value)
        {
            return value switch
            {
                CreateTestCaseDefinitionResponseStatus4.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTestCaseDefinitionResponseStatus4? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateTestCaseDefinitionResponseStatus4.Error,
                _ => null,
            };
        }
    }
}