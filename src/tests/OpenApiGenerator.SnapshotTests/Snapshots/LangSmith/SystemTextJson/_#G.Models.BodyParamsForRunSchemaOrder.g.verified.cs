//HintName: G.Models.BodyParamsForRunSchemaOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Enum for run start date order.
    /// </summary>
    public enum BodyParamsForRunSchemaOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BodyParamsForRunSchemaOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BodyParamsForRunSchemaOrder value)
        {
            return value switch
            {
                BodyParamsForRunSchemaOrder.Asc => "asc",
                BodyParamsForRunSchemaOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BodyParamsForRunSchemaOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BodyParamsForRunSchemaOrder.Asc,
                "desc" => BodyParamsForRunSchemaOrder.Desc,
                _ => null,
            };
        }
    }
}