//HintName: G.Models.CreateModelResponseStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Status creating the model
    /// </summary>
    public enum CreateModelResponseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        CreatingSystemLayer,
        /// <summary>
        /// 
        /// </summary>
        ParsingModelfile,
        /// <summary>
        /// 
        /// </summary>
        Success,
    }

    public static class CreateModelResponseStatusExtensions
    {
        public static string ToValueString(this CreateModelResponseStatus value)
        {
            return value switch
            {
                CreateModelResponseStatus.CreatingSystemLayer => "creating system layer",
                CreateModelResponseStatus.ParsingModelfile => "parsing modelfile",
                CreateModelResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateModelResponseStatus ToEnum(string value)
        {
            return value switch
            {
                "creating system layer" => CreateModelResponseStatus.CreatingSystemLayer,
                "parsing modelfile" => CreateModelResponseStatus.ParsingModelfile,
                "success" => CreateModelResponseStatus.Success,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static CreateModelResponseStatus ToEnum(int value)
        {
            return value switch
            {
                0 => CreateModelResponseStatus.CreatingSystemLayer,
                1 => CreateModelResponseStatus.ParsingModelfile,
                2 => CreateModelResponseStatus.Success,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}