//HintName: G.Models.ModelObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always "model".
    /// </summary>
    public enum ModelObject
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
    }

    public static class ModelObjectExtensions
    {
        public static string ToValueString(this ModelObject value)
        {
            return value switch
            {
                ModelObject.Model => "model",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ModelObject ToEnum(string value)
        {
            return value switch
            {
                "model" => ModelObject.Model,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static ModelObject ToEnum(int value)
        {
            return value switch
            {
                0 => ModelObject.Model,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}