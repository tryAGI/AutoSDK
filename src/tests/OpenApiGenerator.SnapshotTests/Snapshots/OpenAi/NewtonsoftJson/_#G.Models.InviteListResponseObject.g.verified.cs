//HintName: G.Models.InviteListResponseObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `list`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InviteListResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="list")]
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InviteListResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InviteListResponseObject value)
        {
            return value switch
            {
                InviteListResponseObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InviteListResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => InviteListResponseObject.List,
                _ => null,
            };
        }
    }
}