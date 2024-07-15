//HintName: G.Models.OrgsUpdatePatAccessRequestAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Action to apply to the fine-grained personal access token.
    /// </summary>
    public enum OrgsUpdatePatAccessRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Revoke,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsUpdatePatAccessRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsUpdatePatAccessRequestAction value)
        {
            return value switch
            {
                OrgsUpdatePatAccessRequestAction.Revoke => "revoke",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsUpdatePatAccessRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "revoke" => OrgsUpdatePatAccessRequestAction.Revoke,
                _ => null,
            };
        }
    }
}