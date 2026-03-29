//HintName: G.Models.AgentsCountDeployedAgentsSearchItemVariant5Field.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentsCountDeployedAgentsSearchItemVariant5Field
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="templateName")]
        TemplateName,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentsCountDeployedAgentsSearchItemVariant5FieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentsCountDeployedAgentsSearchItemVariant5Field value)
        {
            return value switch
            {
                AgentsCountDeployedAgentsSearchItemVariant5Field.TemplateName => "templateName",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentsCountDeployedAgentsSearchItemVariant5Field? ToEnum(string value)
        {
            return value switch
            {
                "templateName" => AgentsCountDeployedAgentsSearchItemVariant5Field.TemplateName,
                _ => null,
            };
        }
    }
}