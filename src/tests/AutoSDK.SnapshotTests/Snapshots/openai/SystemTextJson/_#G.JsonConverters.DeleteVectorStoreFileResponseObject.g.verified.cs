﻿//HintName: G.JsonConverters.DeleteVectorStoreFileResponseObject.g.cs
#nullable enable

namespace G.JsonConverters
{
    /// <inheritdoc />
    public sealed class DeleteVectorStoreFileResponseObjectJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.DeleteVectorStoreFileResponseObject>
    {
        /// <inheritdoc />
        public override global::G.DeleteVectorStoreFileResponseObject Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::G.DeleteVectorStoreFileResponseObjectExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::G.DeleteVectorStoreFileResponseObject)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::G.DeleteVectorStoreFileResponseObject);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.DeleteVectorStoreFileResponseObject value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::G.DeleteVectorStoreFileResponseObjectExtensions.ToValueString(value));
        }
    }
}
