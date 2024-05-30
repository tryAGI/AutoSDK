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

    public static class ManageHeldAutoModMessagesBodyActionExtensions
    {
        public static string ToValueString(this ManageHeldAutoModMessagesBodyAction value)
        {
            return value switch
            {
                ManageHeldAutoModMessagesBodyAction.ALLOW => "ALLOW",
                ManageHeldAutoModMessagesBodyAction.DENY => "DENY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ManageHeldAutoModMessagesBodyAction ToEnum(string value)
        {
            return value switch
            {
                "ALLOW" => ManageHeldAutoModMessagesBodyAction.ALLOW,
                "DENY" => ManageHeldAutoModMessagesBodyAction.DENY,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ManageHeldAutoModMessagesBodyAction ToEnum(int value)
        {
            return value switch
            {
                0 => ManageHeldAutoModMessagesBodyAction.ALLOW,
                1 => ManageHeldAutoModMessagesBodyAction.DENY,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}