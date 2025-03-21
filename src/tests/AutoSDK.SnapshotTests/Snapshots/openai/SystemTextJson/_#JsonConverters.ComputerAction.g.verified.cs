//HintName: JsonConverters.ComputerAction.g.cs
#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace G.JsonConverters
{
    /// <inheritdoc />
    public class ComputerActionJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::G.ComputerAction>
    {
        /// <inheritdoc />
        public override global::G.ComputerAction Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            var
            readerCopy = reader;
            global::G.Click? click = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Click), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Click> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Click).Name}");
                click = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.DoubleClick? doubleClick = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DoubleClick), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DoubleClick> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DoubleClick).Name}");
                doubleClick = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.Drag? drag = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Drag), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Drag> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Drag).Name}");
                drag = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.KeyPress? keyPress = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.KeyPress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.KeyPress> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.KeyPress).Name}");
                keyPress = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.Move? move = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Move), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Move> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Move).Name}");
                move = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.Screenshot? screenshot = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Screenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Screenshot> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Screenshot).Name}");
                screenshot = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.Scroll? scroll = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Scroll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Scroll> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Scroll).Name}");
                scroll = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.Type? type = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Type), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Type> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Type).Name}");
                type = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            readerCopy = reader;
            global::G.Wait? wait = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Wait), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Wait> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Wait).Name}");
                wait = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }

            var result = new global::G.ComputerAction(
                click,
                doubleClick,
                drag,
                keyPress,
                move,
                screenshot,
                scroll,
                type,
                wait
                );

            if (click != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Click), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Click> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Click).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (doubleClick != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DoubleClick), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DoubleClick> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DoubleClick).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (drag != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Drag), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Drag> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Drag).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (keyPress != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.KeyPress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.KeyPress> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.KeyPress).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (move != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Move), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Move> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Move).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (screenshot != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Screenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Screenshot> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Screenshot).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (scroll != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Scroll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Scroll> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Scroll).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (type != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Type), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Type> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Type).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            else if (wait != null)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Wait), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Wait> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Wait).Name}");
                _ = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::G.ComputerAction value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Click), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Click?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Click).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Click, typeInfo);
            }
            else if (value.IsDoubleClick)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.DoubleClick), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.DoubleClick?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.DoubleClick).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DoubleClick, typeInfo);
            }
            else if (value.IsDrag)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Drag), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Drag?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Drag).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Drag, typeInfo);
            }
            else if (value.IsKeyPress)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.KeyPress), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.KeyPress?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.KeyPress).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.KeyPress, typeInfo);
            }
            else if (value.IsMove)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Move), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Move?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Move).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Move, typeInfo);
            }
            else if (value.IsScreenshot)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Screenshot), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Screenshot?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Screenshot).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Screenshot, typeInfo);
            }
            else if (value.IsScroll)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Scroll), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Scroll?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Scroll).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Scroll, typeInfo);
            }
            else if (value.IsType)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Type), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Type?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Type).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Type, typeInfo);
            }
            else if (value.IsWait)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::G.Wait), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::G.Wait?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::G.Wait).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Wait, typeInfo);
            }
        }
    }
}