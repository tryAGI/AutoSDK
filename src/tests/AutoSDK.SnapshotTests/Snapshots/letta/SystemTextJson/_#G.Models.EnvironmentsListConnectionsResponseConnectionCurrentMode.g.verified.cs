//HintName: G.Models.EnvironmentsListConnectionsResponseConnectionCurrentMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum EnvironmentsListConnectionsResponseConnectionCurrentMode
    {
        /// <summary>
        /// 
        /// </summary>
        AcceptEdits,
        /// <summary>
        /// 
        /// </summary>
        BypassPermissions,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        Plan,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EnvironmentsListConnectionsResponseConnectionCurrentModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EnvironmentsListConnectionsResponseConnectionCurrentMode value)
        {
            return value switch
            {
                EnvironmentsListConnectionsResponseConnectionCurrentMode.AcceptEdits => "acceptEdits",
                EnvironmentsListConnectionsResponseConnectionCurrentMode.BypassPermissions => "bypassPermissions",
                EnvironmentsListConnectionsResponseConnectionCurrentMode.Default => "default",
                EnvironmentsListConnectionsResponseConnectionCurrentMode.Plan => "plan",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EnvironmentsListConnectionsResponseConnectionCurrentMode? ToEnum(string value)
        {
            return value switch
            {
                "acceptEdits" => EnvironmentsListConnectionsResponseConnectionCurrentMode.AcceptEdits,
                "bypassPermissions" => EnvironmentsListConnectionsResponseConnectionCurrentMode.BypassPermissions,
                "default" => EnvironmentsListConnectionsResponseConnectionCurrentMode.Default,
                "plan" => EnvironmentsListConnectionsResponseConnectionCurrentMode.Plan,
                _ => null,
            };
        }
    }
}