//HintName: G.JsonConverters.CodespacesCreateForAuthenticatedUserRequestVariant1Geo.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodespacesCreateForAuthenticatedUserRequestVariant1GeoJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CodespacesCreateForAuthenticatedUserRequestVariant1Geo>
    {
        /// <inheritdoc />
        public override global::G.CodespacesCreateForAuthenticatedUserRequestVariant1Geo ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CodespacesCreateForAuthenticatedUserRequestVariant1Geo existingValue,
            bool hasExistingValue,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            reader = reader ?? throw new global::System.ArgumentNullException(nameof(reader));

            if (hasExistingValue)
            {
                return existingValue;
            }

            switch (reader.TokenType)
            {
                case global::Newtonsoft.Json.JsonToken.String:
                {
                    var stringValue = reader.Value as string ?? reader.ReadAsString();
                    if (stringValue != null)
                    {
                        return global::G.CodespacesCreateForAuthenticatedUserRequestVariant1GeoExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CodespacesCreateForAuthenticatedUserRequestVariant1Geo)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CodespacesCreateForAuthenticatedUserRequestVariant1Geo);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CodespacesCreateForAuthenticatedUserRequestVariant1Geo value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CodespacesCreateForAuthenticatedUserRequestVariant1GeoExtensions.ToValueString(value));
        }
    }
}
