//HintName: G.Models.Create2RequestScriptTextProviderMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Create2RequestScriptTextProviderMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="microsoft")]
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create2RequestScriptTextProviderMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create2RequestScriptTextProviderMicrosoftType value)
        {
            return value switch
            {
                Create2RequestScriptTextProviderMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create2RequestScriptTextProviderMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => Create2RequestScriptTextProviderMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}