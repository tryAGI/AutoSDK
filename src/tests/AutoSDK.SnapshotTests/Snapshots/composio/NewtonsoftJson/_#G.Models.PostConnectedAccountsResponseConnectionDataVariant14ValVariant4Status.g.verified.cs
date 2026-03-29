//HintName: G.Models.PostConnectedAccountsResponseConnectionDataVariant14ValVariant4Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PostConnectedAccountsResponseConnectionDataVariant14ValVariant4Status
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
    public static class PostConnectedAccountsResponseConnectionDataVariant14ValVariant4StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PostConnectedAccountsResponseConnectionDataVariant14ValVariant4Status value)
        {
            return value switch
            {
                PostConnectedAccountsResponseConnectionDataVariant14ValVariant4Status.Inactive => "INACTIVE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PostConnectedAccountsResponseConnectionDataVariant14ValVariant4Status? ToEnum(string value)
        {
            return value switch
            {
                "INACTIVE" => PostConnectedAccountsResponseConnectionDataVariant14ValVariant4Status.Inactive,
                _ => null,
            };
        }
    }
}