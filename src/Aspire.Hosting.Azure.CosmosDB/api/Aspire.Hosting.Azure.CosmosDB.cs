//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Aspire.Hosting
{
    public partial class AzureCosmosDBResource : Azure.AzureProvisioningResource, ApplicationModel.IResourceWithConnectionString, ApplicationModel.IResource, ApplicationModel.IManifestExpressionProvider, ApplicationModel.IValueProvider, ApplicationModel.IValueWithReferences, ApplicationModel.IResourceWithEndpoints, Azure.IResourceWithAzureFunctionsConfig
    {
        public AzureCosmosDBResource(string name, System.Action<Azure.AzureResourceInfrastructure> configureInfrastructure) : base(default!, default!) { }

        public Azure.BicepSecretOutputReference ConnectionString { get { throw null; } }

        public ApplicationModel.ReferenceExpression ConnectionStringExpression { get { throw null; } }

        public Azure.BicepOutputReference ConnectionStringOutput { get { throw null; } }

        public bool IsEmulator { get { throw null; } }

        [System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, "ConnectionStringSecretOutput")]
        public bool UseAccessKeyAuthentication { get { throw null; } }

        public void ApplyAzureFunctionsConfiguration(System.Collections.Generic.IDictionary<string, object> target, string connectionName) { }
    }

    public static partial class AzureCosmosExtensions
    {
        public static ApplicationModel.IResourceBuilder<AzureCosmosDBResource> AddAzureCosmosDB(this IDistributedApplicationBuilder builder, string name) { throw null; }

        [System.Obsolete("This method is obsolete and will be removed in a future version. Use WithDatabase instead to add a Cosmos DB database.")]
        public static ApplicationModel.IResourceBuilder<AzureCosmosDBResource> AddDatabase(this ApplicationModel.IResourceBuilder<AzureCosmosDBResource> builder, string databaseName) { throw null; }

        public static ApplicationModel.IResourceBuilder<AzureCosmosDBResource> RunAsEmulator(this ApplicationModel.IResourceBuilder<AzureCosmosDBResource> builder, System.Action<ApplicationModel.IResourceBuilder<Azure.AzureCosmosDBEmulatorResource>>? configureContainer = null) { throw null; }

        [System.Diagnostics.CodeAnalysis.Experimental("ASPIRECOSMOS001", UrlFormat = "https://aka.ms/dotnet/aspire/diagnostics#{0}")]
        public static ApplicationModel.IResourceBuilder<AzureCosmosDBResource> RunAsPreviewEmulator(this ApplicationModel.IResourceBuilder<AzureCosmosDBResource> builder, System.Action<ApplicationModel.IResourceBuilder<Azure.AzureCosmosDBEmulatorResource>>? configureContainer = null) { throw null; }

        public static ApplicationModel.IResourceBuilder<AzureCosmosDBResource> WithAccessKeyAuthentication(this ApplicationModel.IResourceBuilder<AzureCosmosDBResource> builder) { throw null; }

        public static ApplicationModel.IResourceBuilder<AzureCosmosDBResource> WithDatabase(this ApplicationModel.IResourceBuilder<AzureCosmosDBResource> builder, string name, System.Action<Azure.CosmosDB.CosmosDBDatabase>? configure = null) { throw null; }

        [System.Diagnostics.CodeAnalysis.Experimental("ASPIRECOSMOS001", UrlFormat = "https://aka.ms/dotnet/aspire/diagnostics#{0}")]
        public static ApplicationModel.IResourceBuilder<Azure.AzureCosmosDBEmulatorResource> WithDataExplorer(this ApplicationModel.IResourceBuilder<Azure.AzureCosmosDBEmulatorResource> builder, int? port = null) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureCosmosDBEmulatorResource> WithDataVolume(this ApplicationModel.IResourceBuilder<Azure.AzureCosmosDBEmulatorResource> builder, string? name = null) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureCosmosDBEmulatorResource> WithGatewayPort(this ApplicationModel.IResourceBuilder<Azure.AzureCosmosDBEmulatorResource> builder, int? port) { throw null; }

        public static ApplicationModel.IResourceBuilder<Azure.AzureCosmosDBEmulatorResource> WithPartitionCount(this ApplicationModel.IResourceBuilder<Azure.AzureCosmosDBEmulatorResource> builder, int count) { throw null; }
    }
}

namespace Aspire.Hosting.Azure
{
    public partial class AzureCosmosDBEmulatorResource : ApplicationModel.ContainerResource, ApplicationModel.IResource
    {
        public AzureCosmosDBEmulatorResource(AzureCosmosDBResource innerResource) : base(default!, default) { }

        public override ApplicationModel.ResourceAnnotationCollection Annotations { get { throw null; } }
    }
}

namespace Aspire.Hosting.Azure.CosmosDB
{
    public partial class CosmosDBContainer
    {
        public CosmosDBContainer(string name, string partitionKeyPath) { }

        public string Name { get { throw null; } set { } }

        public string PartitionKeyPath { get { throw null; } set { } }
    }

    public partial class CosmosDBDatabase
    {
        public CosmosDBDatabase(string name) { }

        public System.Collections.Generic.List<CosmosDBContainer> Containers { get { throw null; } }

        public string Name { get { throw null; } set { } }
    }
}