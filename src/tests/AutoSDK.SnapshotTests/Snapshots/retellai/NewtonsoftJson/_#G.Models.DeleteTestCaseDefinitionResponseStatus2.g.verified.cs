//HintName: G.Models.DeleteTestCaseDefinitionResponseStatus2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteTestCaseDefinitionResponseStatus2
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
    public static class DeleteTestCaseDefinitionResponseStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteTestCaseDefinitionResponseStatus2 value)
        {
            return value switch
            {
                DeleteTestCaseDefinitionResponseStatus2.Error => "error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteTestCaseDefinitionResponseStatus2? ToEnum(string value)
        {
            return value switch
            {
                "error" => DeleteTestCaseDefinitionResponseStatus2.Error,
                _ => null,
            };
        }
    }
}