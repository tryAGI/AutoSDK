//HintName: G.Models.ManageHeldAutoModMessagesBodyAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The action to take for the message. Possible values are:  <br/>
    ///   <br/>
    /// * ALLOW<br/>
    /// * DENY
    /// </summary>
    public enum ManageHeldAutoModMessagesBodyAction
    {
        /// <summary>
        /// 
        /// </summary>
        Allow,
        /// <summary>
        /// 
        /// </summary>
        Deny,
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
                ManageHeldAutoModMessagesBodyAction.Allow => "ALLOW",
                ManageHeldAutoModMessagesBodyAction.Deny => "DENY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ManageHeldAutoModMessagesBodyAction? ToEnum(string value)
        {
            return value switch
            {
                "ALLOW" => ManageHeldAutoModMessagesBodyAction.Allow,
                "DENY" => ManageHeldAutoModMessagesBodyAction.Deny,
                _ => null,
            };
        }
    }
}