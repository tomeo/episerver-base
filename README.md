# DATABASE
The project is setup to run using localdb. This can easily be changed by altering the connectionString in connectionStings.config.

# Using localdb
1. Install SQL Server Express.
2. Create EPiServerBase.mdf and place it in EPiServerBase/App_Data
3. Initialise the database by opening the NuGet Package Manager and running Initialize-EPiDatabase (more information at http://world.episerver.com/documentation/Items/Developers-Guide/EPiServer-CMS/8/Deployment/About-the-database/).
4. Connect to the database using SQL Management Studio using Server Name = (LocalDb)\mssqllocaldb and Windows Authentication.
5. Activate workflows by following this guide:
http://world.episerver.com/documentation/Items/Developers-Guide/EPiServer-CMS/8/Workflows/Activating-workflows/

# THINGS I WANT TO ADD
* Navigation
* Device Detection
* Sections
* ContentFilter
* PageTypeList
* CategoryList
