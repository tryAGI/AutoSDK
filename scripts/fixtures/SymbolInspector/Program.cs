using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json;
using AutoSDK.CLI.Trimming;

var assembly = args[0];
using var file = File.OpenRead(assembly);
using var pe = new PEReader(file);
var embedded = pe.ReadDebugDirectory().FirstOrDefault(entry => entry.Type == DebugDirectoryEntryType.EmbeddedPortablePdb);
using var pdb = args.Length > 1 && File.Exists(args[1]) ? File.OpenRead(args[1]) : null;
using var provider = embedded.DataSize > 0 ? pe.ReadEmbeddedPortablePdbDebugDirectoryData(embedded)
    : pdb is not null ? MetadataReaderProvider.FromPortablePdbStream(pdb) : null;
var reader = provider?.GetMetadataReader();
var sourceLink = string.Empty;
var embeddedSources = 0;
if (reader is not null)
{
    foreach (var handle in reader.CustomDebugInformation)
    {
        var information = reader.GetCustomDebugInformation(handle);
        var kind = reader.GetGuid(information.Kind);
        if (kind == new Guid("cc110556-a091-4d38-9fec-25ab9a351a6a"))
            sourceLink = Encoding.UTF8.GetString(reader.GetBlobBytes(information.Value));
        if (kind == new Guid("0e8a571b-6926-466e-b4ad-8ab04611f5fe"))
            embeddedSources++;
    }
}
Console.WriteLine(JsonSerializer.Serialize(new
{
    assembly = AssemblyFootprint.Read(assembly),
    documents = reader?.Documents.Count ?? 0,
    embeddedSources,
    sourceLink,
    externalPdbBytes = pdb?.Length ?? 0,
}));
