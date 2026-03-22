//HintName: G.Models.DataTypeItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DataTypeItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="<cross_reference>")]
        x_crossReference_,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blob")]
        Blob,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date")]
        Date,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="date[]")]
        DateArray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="geoCoordinates")]
        GeoCoordinates,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="int")]
        Int,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="int[]")]
        IntArray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number")]
        Number,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="number[]")]
        NumberArray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="object")]
        Object,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="object[]")]
        ObjectArray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phoneNumber")]
        PhoneNumber,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string")]
        String,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="string[]")]
        StringArray,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uuid")]
        Uuid,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="uuid[]")]
        UuidArray,
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
                DataTypeItem.x_crossReference_ => "<cross_reference>",
                DataTypeItem.Blob => "blob",
                DataTypeItem.Date => "date",
                DataTypeItem.DateArray => "date[]",
                DataTypeItem.GeoCoordinates => "geoCoordinates",
                DataTypeItem.Int => "int",
                DataTypeItem.IntArray => "int[]",
                DataTypeItem.Number => "number",
                DataTypeItem.NumberArray => "number[]",
                DataTypeItem.Object => "object",
                DataTypeItem.ObjectArray => "object[]",
                DataTypeItem.PhoneNumber => "phoneNumber",
                DataTypeItem.String => "string",
                DataTypeItem.StringArray => "string[]",
                DataTypeItem.Uuid => "uuid",
                DataTypeItem.UuidArray => "uuid[]",
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
                "<cross_reference>" => DataTypeItem.x_crossReference_,
                "blob" => DataTypeItem.Blob,
                "date" => DataTypeItem.Date,
                "date[]" => DataTypeItem.DateArray,
                "geoCoordinates" => DataTypeItem.GeoCoordinates,
                "int" => DataTypeItem.Int,
                "int[]" => DataTypeItem.IntArray,
                "number" => DataTypeItem.Number,
                "number[]" => DataTypeItem.NumberArray,
                "object" => DataTypeItem.Object,
                "object[]" => DataTypeItem.ObjectArray,
                "phoneNumber" => DataTypeItem.PhoneNumber,
                "string" => DataTypeItem.String,
                "string[]" => DataTypeItem.StringArray,
                "uuid" => DataTypeItem.Uuid,
                "uuid[]" => DataTypeItem.UuidArray,
                _ => null,
            };
        }
    }
}