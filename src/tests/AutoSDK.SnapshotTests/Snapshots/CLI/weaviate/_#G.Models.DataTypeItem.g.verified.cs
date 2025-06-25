//HintName: G.Models.DataTypeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DataTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        String,
        /// <summary>
        /// 
        /// </summary>
        StringArray,
        /// <summary>
        /// 
        /// </summary>
        Object,
        /// <summary>
        /// 
        /// </summary>
        ObjectArray,
        /// <summary>
        /// 
        /// </summary>
        Int,
        /// <summary>
        /// 
        /// </summary>
        IntArray,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        NumberArray,
        /// <summary>
        /// 
        /// </summary>
        Date,
        /// <summary>
        /// 
        /// </summary>
        DateArray,
        /// <summary>
        /// 
        /// </summary>
        Uuid,
        /// <summary>
        /// 
        /// </summary>
        UuidArray,
        /// <summary>
        /// 
        /// </summary>
        GeoCoordinates,
        /// <summary>
        /// 
        /// </summary>
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        Blob,
        /// <summary>
        /// 
        /// </summary>
        x_crossReference_,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataTypeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataTypeItem value)
        {
            return value switch
            {
                DataTypeItem.String => "string",
                DataTypeItem.StringArray => "string[]",
                DataTypeItem.Object => "object",
                DataTypeItem.ObjectArray => "object[]",
                DataTypeItem.Int => "int",
                DataTypeItem.IntArray => "int[]",
                DataTypeItem.Number => "number",
                DataTypeItem.NumberArray => "number[]",
                DataTypeItem.Date => "date",
                DataTypeItem.DateArray => "date[]",
                DataTypeItem.Uuid => "uuid",
                DataTypeItem.UuidArray => "uuid[]",
                DataTypeItem.GeoCoordinates => "geoCoordinates",
                DataTypeItem.PhoneNumber => "phoneNumber",
                DataTypeItem.Blob => "blob",
                DataTypeItem.x_crossReference_ => "<cross_reference>",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataTypeItem? ToEnum(string value)
        {
            return value switch
            {
                "string" => DataTypeItem.String,
                "string[]" => DataTypeItem.StringArray,
                "object" => DataTypeItem.Object,
                "object[]" => DataTypeItem.ObjectArray,
                "int" => DataTypeItem.Int,
                "int[]" => DataTypeItem.IntArray,
                "number" => DataTypeItem.Number,
                "number[]" => DataTypeItem.NumberArray,
                "date" => DataTypeItem.Date,
                "date[]" => DataTypeItem.DateArray,
                "uuid" => DataTypeItem.Uuid,
                "uuid[]" => DataTypeItem.UuidArray,
                "geoCoordinates" => DataTypeItem.GeoCoordinates,
                "phoneNumber" => DataTypeItem.PhoneNumber,
                "blob" => DataTypeItem.Blob,
                "<cross_reference>" => DataTypeItem.x_crossReference_,
                _ => null,
            };
        }
    }
}