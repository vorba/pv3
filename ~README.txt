
IMPORTANT DEPLOYMENT INSTRUCTIONS

AppHarbor
---------
1.  Change Connection Strings in project Web.Config to point to AppHarbor SQL instance
2.  Open PurevisionModel.edmx with... XML editor and update PurevisionModel.Store ProviderManifestToken="2008" (from 2012) to support AppHarbor share SQL instance, which is 2008.


