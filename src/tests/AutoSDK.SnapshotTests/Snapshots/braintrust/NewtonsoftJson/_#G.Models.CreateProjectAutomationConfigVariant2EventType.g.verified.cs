//HintName: G.Models.CreateProjectAutomationConfigVariant2EventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of automation.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateProjectAutomationConfigVariant2EventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="btql_export")]
        BtqlExport,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateProjectAutomationConfigVariant2EventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateProjectAutomationConfigVariant2EventType value)
        {
            return value switch
            {
                CreateProjectAutomationConfigVariant2EventType.BtqlExport => "btql_export",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateProjectAutomationConfigVariant2EventType? ToEnum(string value)
        {
            return value switch
            {
                "btql_export" => CreateProjectAutomationConfigVariant2EventType.BtqlExport,
                _ => null,
            };
        }
    }
}