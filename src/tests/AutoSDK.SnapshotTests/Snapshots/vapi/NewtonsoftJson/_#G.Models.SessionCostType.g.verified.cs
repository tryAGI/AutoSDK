//HintName: G.Models.SessionCostType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of cost, always 'session' for this class.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SessionCostType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session")]
        Session,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionCostTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionCostType value)
        {
            return value switch
            {
                SessionCostType.Session => "session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionCostType? ToEnum(string value)
        {
            return value switch
            {
                "session" => SessionCostType.Session,
                _ => null,
            };
        }
    }
}