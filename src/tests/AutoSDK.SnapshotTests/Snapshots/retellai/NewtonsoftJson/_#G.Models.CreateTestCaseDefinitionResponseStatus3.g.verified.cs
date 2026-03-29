//HintName: G.Models.CreateTestCaseDefinitionResponseStatus3.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTestCaseDefinitionResponseStatus3
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
    public static class CreateTestCaseDefinitionResponseStatus3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTestCaseDefinitionResponseStatus3 value)
        {
            return value switch
            {
                CreateTestCaseDefinitionResponseStatus3.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTestCaseDefinitionResponseStatus3? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateTestCaseDefinitionResponseStatus3.Error,
                _ => null,
            };
        }
    }
}