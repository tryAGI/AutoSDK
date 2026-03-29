//HintName: G.JsonConverters.Entity.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class EntityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.Entity>
    {
        /// <inheritdoc />
        public override global::G.Entity Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.EntityDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.EntityDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.EntityDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.CompanyEntity? company = default;
            if (discriminator?.Type == global::G.EntityDiscriminatorType.Company)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompanyEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompanyEntity> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CompanyEntity)}");
                company = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.PersonEntity? person = default;
            if (discriminator?.Type == global::G.EntityDiscriminatorType.Person)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PersonEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PersonEntity> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.PersonEntity)}");
                person = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.Entity(
                discriminator?.Type,
                company,

                person
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.Entity value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCompany)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CompanyEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CompanyEntity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CompanyEntity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Company, typeInfo);
            }
            else if (value.IsPerson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.PersonEntity), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.PersonEntity?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.PersonEntity).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Person, typeInfo);
            }
        }
    }
}