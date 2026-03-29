//HintName: G.Models.GetConnectedAccountsResponseItemStateVariant8ValVariant4Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetConnectedAccountsResponseItemStateVariant8ValVariant4Status
    {
        /// <summary>
        /// 
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetConnectedAccountsResponseItemStateVariant8ValVariant4StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetConnectedAccountsResponseItemStateVariant8ValVariant4Status value)
        {
            return value switch
            {
                GetConnectedAccountsResponseItemStateVariant8ValVariant4Status.Inactive => "INACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetConnectedAccountsResponseItemStateVariant8ValVariant4Status? ToEnum(string value)
        {
            return value switch
            {
                "INACTIVE" => GetConnectedAccountsResponseItemStateVariant8ValVariant4Status.Inactive,
                _ => null,
            };
        }
    }
}