# NetOnJets

This is an attempt to build a more streamlined scaffolding process of ASP.NET through the console.

This is an open source project with the purpose of saving coders time and saving money for businesses. Also this project is to help me continue to learn and grow in my understanding of C# and DotNet so if you have love, hate or, criticism let me know at scy0846@gmail.com

##Future Plans
For example the design of this project is to do the following...

To create a new ASP.NET MVC5 Project you would type...

    'jet new "Blog"' 

Blog is the title of the application. It would generate everything needed to build a new MVC5 Application and will take arguments to build other types of projects.

To create a new model with attributes you would type...

    'jet g "PostModel" -a "Title", "Body", "CreatedAt:DateTime", "UserId:Int"

This will create a PostModel with an Id(automatically generated you wouldn't need to type it here), a Title with type String, a Body with type String, a CreatedAt with type DateTime, and a UserId with type Int.
If you wanted to use a controller with scaffolded views for handling CRUD you would use a -c -v and if you wanted to use a repository this will automatically generate a new C# Project with the title ProjectTitle.Core and create a Repository and Mapping folder with EF Mapping


To create a new controller you would type...

    'jet g "PostController" -v "Create", "Read", "Update", "Delete", "Index"

This will be expected to create this controller with view pages, though doing it this way the views will not have scaffolded pages.


Eventually you should be able to generate or delete projects, models, controllers, and other things. I will eventually add in a nuget installer/ uninstaller. It does build solutions for now, but I want to add an option to build just select projects or build with nuget package restore.


Overall this is a work in progress. It's to help me learn for now and get better at building in C#. I plan on working on this for a while to make this more robust and to add more scaffolds. Feel free to add or suggest something that you would like to see scaffolded. 

As of 3/11/2015 this project is not useable. It will only build projects for now.

Feel like contributing? Fork it and submit a pull request. Thank you!
