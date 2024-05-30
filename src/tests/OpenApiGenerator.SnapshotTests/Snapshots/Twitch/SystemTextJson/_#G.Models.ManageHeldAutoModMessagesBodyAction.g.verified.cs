//HintName: G.Models.ManageHeldAutoModMessagesBodyAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The action to take for the message. Possible values are:  
    ///   
    /// * ALLOW
    /// * DENY
    /// </summary>
    public enum ManageHeldAutoModMessagesBodyAction
    {
        /// <summary>
        /// 
        /// </summary>
        ALLOW,
        /// <summary>
        /// 
        /// </summary>
        DENY,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ManageHeldAutoModMessagesBodyActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ManageHeldAutoModMessagesBodyAction value)
        {
            return value switch
            {
                ManageHeldAutoModMessagesBodyAction.ALLOW => "ALLOW",
                ManageHeldAutoModMessagesBodyAction.DENY => "DENY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageHeldAutoModMessagesBodyAction ToEnum(string value)
        {
            return value switch
            {
                "ALLOW" => ManageHeldAutoModMessagesBodyAction.ALLOW,
                "DENY" => ManageHeldAutoModMessagesBodyAction.DENY,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}