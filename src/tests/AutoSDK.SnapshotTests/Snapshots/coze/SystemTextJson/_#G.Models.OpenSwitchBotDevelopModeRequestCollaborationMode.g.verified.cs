//HintName: G.Models.OpenSwitchBotDevelopModeRequestCollaborationMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum OpenSwitchBotDevelopModeRequestCollaborationMode
    {
        /// <summary>
        /// 
        /// </summary>
        Collaboration,
        /// <summary>
        /// 
        /// </summary>
        Single,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OpenSwitchBotDevelopModeRequestCollaborationModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OpenSwitchBotDevelopModeRequestCollaborationMode value)
        {
            return value switch
            {
                OpenSwitchBotDevelopModeRequestCollaborationMode.Collaboration => "collaboration",
                OpenSwitchBotDevelopModeRequestCollaborationMode.Single => "single",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OpenSwitchBotDevelopModeRequestCollaborationMode? ToEnum(string value)
        {
            return value switch
            {
                "collaboration" => OpenSwitchBotDevelopModeRequestCollaborationMode.Collaboration,
                "single" => OpenSwitchBotDevelopModeRequestCollaborationMode.Single,
                _ => null,
            };
        }
    }
}