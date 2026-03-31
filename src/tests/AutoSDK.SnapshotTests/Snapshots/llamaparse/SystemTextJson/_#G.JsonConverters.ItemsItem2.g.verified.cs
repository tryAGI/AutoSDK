//HintName: G.JsonConverters.ItemsItem2.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ItemsItem2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ItemsItem2>
    {
        /// <inheritdoc />
        public override global::G.ItemsItem2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeaderItemItemDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeaderItemItemDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HeaderItemItemDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::G.TextItem? text = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TextItem)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.HeadingItem? heading = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.Heading)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeadingItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeadingItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.HeadingItem)}");
                heading = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ListItem? list = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.List)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ListItem)}");
                list = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.CodeItem? code = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.Code)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.CodeItem)}");
                code = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.TableItem? table = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.Table)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TableItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TableItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.TableItem)}");
                table = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.ImageItem? image = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.Image)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.ImageItem)}");
                image = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::G.LinkItem? link = default;
            if (discriminator?.Type == global::G.HeaderItemItemDiscriminatorType.Link)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LinkItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LinkItem> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::G.LinkItem)}");
                link = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::G.ItemsItem2(
                discriminator?.Type,
                text,

                heading,

                list,

                code,

                table,

                image,

                link
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ItemsItem2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TextItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TextItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TextItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text!, typeInfo);
            }
            else if (value.IsHeading)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.HeadingItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.HeadingItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.HeadingItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Heading!, typeInfo);
            }
            else if (value.IsList)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ListItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ListItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ListItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.List!, typeInfo);
            }
            else if (value.IsCode)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.CodeItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.CodeItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.CodeItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Code!, typeInfo);
            }
            else if (value.IsTable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.TableItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.TableItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.TableItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Table!, typeInfo);
            }
            else if (value.IsImage)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.ImageItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.ImageItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.ImageItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Image!, typeInfo);
            }
            else if (value.IsLink)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.LinkItem), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.LinkItem?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.LinkItem).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Link!, typeInfo);
            }
        }
    }
}