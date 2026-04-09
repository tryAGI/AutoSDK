//HintName: G.JsonConverters.CodespacesCreateForAuthenticatedUserRequestVariant2Geo.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class CodespacesCreateForAuthenticatedUserRequestVariant2GeoJsonConverter : global::Newtonsoft.Json.JsonConverter<global::G.CodespacesCreateForAuthenticatedUserRequestVariant2Geo>
    {
        /// <inheritdoc />
        public override global::G.CodespacesCreateForAuthenticatedUserRequestVariant2Geo ReadJson(
            global::Newtonsoft.Json.JsonReader reader,
            global::System.Type objectType,
            global::G.CodespacesCreateForAuthenticatedUserRequestVariant2Geo existingValue,
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
                        return global::G.CodespacesCreateForAuthenticatedUserRequestVariant2GeoExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Integer:
                {
                    var numValue = reader.ReadAsInt32();
                    if (numValue != null)
                    {
                        return (global::G.CodespacesCreateForAuthenticatedUserRequestVariant2Geo)numValue.Value;
                    }

                    break;
                }
                case global::Newtonsoft.Json.JsonToken.Null:
                {
                    return default(global::G.CodespacesCreateForAuthenticatedUserRequestVariant2Geo);
                }
            }

            return default;
        }

        /// <inheritdoc />
        public override void WriteJson(
            global::Newtonsoft.Json.JsonWriter writer,
            global::G.CodespacesCreateForAuthenticatedUserRequestVariant2Geo value,
            global::Newtonsoft.Json.JsonSerializer serializer)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteValue(global::G.CodespacesCreateForAuthenticatedUserRequestVariant2GeoExtensions.ToValueString(value));
        }
    }
}
