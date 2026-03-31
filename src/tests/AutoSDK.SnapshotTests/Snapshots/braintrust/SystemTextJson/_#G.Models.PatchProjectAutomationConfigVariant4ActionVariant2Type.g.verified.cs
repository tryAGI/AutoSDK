//HintName: G.Models.PatchProjectAutomationConfigVariant4ActionVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of action to take
    /// </summary>
    public enum PatchProjectAutomationConfigVariant4ActionVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Slack,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PatchProjectAutomationConfigVariant4ActionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchProjectAutomationConfigVariant4ActionVariant2Type value)
        {
            return value switch
            {
                PatchProjectAutomationConfigVariant4ActionVariant2Type.Slack => "slack",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchProjectAutomationConfigVariant4ActionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "slack" => PatchProjectAutomationConfigVariant4ActionVariant2Type.Slack,
                _ => null,
            };
        }
    }
}