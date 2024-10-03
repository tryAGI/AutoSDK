//HintName: G.Models.ObjectsGetResponseVariant3ResultStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: SUCCESS
    /// </summary>
    public enum ObjectsGetResponseVariant3ResultStatus
    {
        /// <summary>
        /// 
        /// </summary>
        SUCCESS,
        /// <summary>
        /// 
        /// </summary>
        PENDING,
        /// <summary>
        /// 
        /// </summary>
        FAILED,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ObjectsGetResponseVariant3ResultStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectsGetResponseVariant3ResultStatus value)
        {
            return value switch
            {
                ObjectsGetResponseVariant3ResultStatus.SUCCESS => "SUCCESS",
                ObjectsGetResponseVariant3ResultStatus.PENDING => "PENDING",
                ObjectsGetResponseVariant3ResultStatus.FAILED => "FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectsGetResponseVariant3ResultStatus? ToEnum(string value)
        {
            return value switch
            {
                "SUCCESS" => ObjectsGetResponseVariant3ResultStatus.SUCCESS,
                "PENDING" => ObjectsGetResponseVariant3ResultStatus.PENDING,
                "FAILED" => ObjectsGetResponseVariant3ResultStatus.FAILED,
                _ => null,
            };
        }
    }
}