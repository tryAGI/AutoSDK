//HintName: G.Models.OrgsUpdatePatAccessesRequestAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Action to apply to the fine-grained personal access token.
    /// </summary>
    public enum OrgsUpdatePatAccessesRequestAction
    {
        /// <summary>
        /// 
        /// </summary>
        Revoke,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrgsUpdatePatAccessesRequestActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrgsUpdatePatAccessesRequestAction value)
        {
            return value switch
            {
                OrgsUpdatePatAccessesRequestAction.Revoke => "revoke",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrgsUpdatePatAccessesRequestAction? ToEnum(string value)
        {
            return value switch
            {
                "revoke" => OrgsUpdatePatAccessesRequestAction.Revoke,
                _ => null,
            };
        }
    }
}