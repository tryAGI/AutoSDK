//HintName: G.Models.CreateTestCaseDefinitionResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTestCaseDefinitionResponseStatus
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
    public static class CreateTestCaseDefinitionResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTestCaseDefinitionResponseStatus value)
        {
            return value switch
            {
                CreateTestCaseDefinitionResponseStatus.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTestCaseDefinitionResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "error" => CreateTestCaseDefinitionResponseStatus.Error,
                _ => null,
            };
        }
    }
}