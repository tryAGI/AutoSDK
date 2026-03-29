//HintName: G.Models.DataCollection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Data collection setting. If no available model provider meets the requirement, your request will return an error.<br/>
    /// - allow: (default) allow providers which store user data non-transiently and may train on it<br/>
    /// - deny: use only providers which do not collect user data.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DataCollection
    {
        /// <summary>
        /// (default) allow providers which store user data non-transiently and may train on it
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="allow")]
        Allow,
        /// <summary>
        /// use only providers which do not collect user data.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deny")]
        Deny,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataCollectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataCollection value)
        {
            return value switch
            {
                DataCollection.Allow => "allow",
                DataCollection.Deny => "deny",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataCollection? ToEnum(string value)
        {
            return value switch
            {
                "allow" => DataCollection.Allow,
                "deny" => DataCollection.Deny,
                _ => null,
            };
        }
    }
}