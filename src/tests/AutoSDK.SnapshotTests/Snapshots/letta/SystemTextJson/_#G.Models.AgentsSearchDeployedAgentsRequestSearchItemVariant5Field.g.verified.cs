//HintName: G.Models.AgentsSearchDeployedAgentsRequestSearchItemVariant5Field.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentsSearchDeployedAgentsRequestSearchItemVariant5Field
    {
        /// <summary>
        /// 
        /// </summary>
        TemplateName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsSearchDeployedAgentsRequestSearchItemVariant5FieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsSearchDeployedAgentsRequestSearchItemVariant5Field value)
        {
            return value switch
            {
                AgentsSearchDeployedAgentsRequestSearchItemVariant5Field.TemplateName => "templateName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsSearchDeployedAgentsRequestSearchItemVariant5Field? ToEnum(string value)
        {
            return value switch
            {
                "templateName" => AgentsSearchDeployedAgentsRequestSearchItemVariant5Field.TemplateName,
                _ => null,
            };
        }
    }
}