//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant3ValVariant4Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsResponseConnectionDataVariant3ValVariant4Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="INACTIVE")]
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PostConnectedAccountsResponseConnectionDataVariant3ValVariant4StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant3ValVariant4Status value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant3ValVariant4Status.Inactive => "INACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant3ValVariant4Status? ToEnum(string value)
        {
            return value switch
            {
                "INACTIVE" => PostConnectedAccountsResponseConnectionDataVariant3ValVariant4Status.Inactive,
                _ => null,
            };
        }
    }
}