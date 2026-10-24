using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

namespace AutoSDK.CLI.Trimming;

/// <summary>Physical PE payload sizes. The non-PDB remainder also contains headers, resources and padding.</summary>
internal sealed record AssemblyFootprint(
    string File,
    long FileBytes,
    long EmbeddedPortablePdbBytes,
    long BytesWithoutEmbeddedPdbPayload,
    long MetadataBytes,
    long IlBytes,
    int TypeCount,
    int MethodCount,
    int FieldCount)
{
    public static AssemblyFootprint? Read(string path)
    {
        using var stream = System.IO.File.OpenRead(path);
        try
        {
            using var pe = new PEReader(stream);
            if (!pe.HasMetadata)
                return null;

            var metadata = pe.GetMetadataReader();
            // DataSize is the compressed on-disk MPDB entry, not the decompressed PDB size.
            var pdbBytes = pe.ReadDebugDirectory()
                .Where(entry => entry.Type == DebugDirectoryEntryType.EmbeddedPortablePdb)
                .Sum(entry => (long)entry.DataSize);
            var ilBytes = metadata.MethodDefinitions.Sum(handle =>
            {
                var method = metadata.GetMethodDefinition(handle);
                return method.RelativeVirtualAddress == 0
                    ? 0L
                    : pe.GetMethodBody(method.RelativeVirtualAddress).GetILBytes()?.LongLength ?? 0L;
            });

            return new(
                Path.GetFileName(path),
                stream.Length,
                pdbBytes,
                stream.Length - pdbBytes,
                pe.PEHeaders.CorHeader!.MetadataDirectory.Size,
                ilBytes,
                metadata.TypeDefinitions.Count,
                metadata.MethodDefinitions.Count,
                metadata.FieldDefinitions.Count);
        }
        catch (BadImageFormatException)
        {
            // Native libraries and non-PE files have no managed metadata to report.
            return null;
        }
    }
}
