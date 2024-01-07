# Planet

My first Razor project, the work was done in a team during my third semester of software development.

## Planets 
In this practical work, there are two parts to be done in a team of two or three, mandatory. NASA wants to use your expertise to technologically refresh its website about the planets in the solar system. It wants to proceed in phases. Its first priority is to obtain 2 pages that will deal with information about the planets, as well as another one for conducting a survey. You are tasked with producing these pages. Here is an analysis of each page:

### Index.cshtml:
This page only contains the code to display the planets based on the screen size. Images and texts come from the database provided with this statement.

### _Layout.cshtml:
This page contains the header, menu, and footer. The background image and logo are provided with the statement. The requested layouts are:
- col-xl-?:
- col-lg-?:
- col-md-?:
- Others:

### Planet.cshtml:
When the user clicks on the title of a planet, the site opens a page with the details of that planet. The images and texts are in the database.

N.B.: The texts in this part are taken from a specified website in the references. You will also find references for the images.

Color palettes used:
- Black
- White
- #c5d6ff
- #6793d2

Font used for H1 to H6: "Raleway", "Helvetica Neue", sans-serif

### To Note:
1. In Visual Studio, create a new ASP.Net (.NET Core) project and choose Web Application. Push this initial version to DevOps - Git, in the master branch. Make sure all developers can operate.
2. Retrieve the database named PlanètesBD (.MDF and .LDF) and place it in a folder (e.g., Data) in your project. Connect your application to the database. Since each programmer can put their project in any folder, and the connection string may be different from one developer to another, here's what I suggest:
   - In appsettings.json:
     ```json
     "ConnectionStrings": {
       "PlanètesContext": "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=[PROJET]\\Data\\PlanètesBD.mdf;Integrated Security=True"
     }
     ```
     Don't forget UTF-8 encoding!!! → For accents!
   - In Program.cs:
     ```csharp
     builder.Services.AddDbContext<PlanètesContext>(options =>
       options.UseSqlServer(builder.Configuration.GetConnectionString("PlanètesContext")
       .Replace("[PROJET]", builder.Environment.ContentRootPath)));
     ```

3. Create the Planet model with the necessary properties to link to the table.
4. Perform the necessary actions to be able to connect to the database. Add a class for the database context. A service that, from the context, can query the table.
5. Prepare the static part of the site (e.g., images, css, js, etc.).
6. Activate the services necessary for the proper functioning of the application.
7. Add Razor pages to produce the requested display above.

## Planets – Survey Form 
This part involves designing a form to survey the company's customers.
1) Razor page form:
   - Sondage.cshtml: Design the form by adding fields according to the example on the right in three columns. You must create a model named Sondage and add the necessary properties to collect information.
2) Property Validation:
   - First Name: Required
   - Last Name: Required
   - Knowledge Level: A choice must have been made.
   - Email: Not mandatory. However, if specified, it must follow its format.
   - Promotion Code: If specified, it must follow the requested format. Uppercase letters only. Numbers and hyphens in the right places. Use a regular expression.

3) Model Validation:
   - If the checkbox "Do you want to be informed..." is checked, make sure an email is specified.
4) Message to display once submitted:

### To Note:
1. Add a Razor page named Sondage.cshtml. Deposit the form fields there.
2. Add a model named Sondage.cs in which you must declare the properties that will be associated with the form fields. Define the validation attributes there.
