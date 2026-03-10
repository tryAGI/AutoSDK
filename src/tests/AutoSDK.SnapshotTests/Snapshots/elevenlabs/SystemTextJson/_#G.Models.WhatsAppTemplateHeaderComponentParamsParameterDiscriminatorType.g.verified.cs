//HintName: G.Models.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Location,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType value)
        {
            return value switch
            {
                WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Document => "document",
                WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Image => "image",
                WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Location => "location",
                WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "document" => WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Document,
                "image" => WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Image,
                "location" => WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Location,
                "text" => WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}