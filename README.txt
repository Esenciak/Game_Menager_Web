Stworzyć do każdego Controllera front
	LogginController => View - Loggin
	HomeController => View - Index
	Category => zapas zobaczymy co będzie w kursie

	Migracja sql, stworzenie bazy



	użyj update-database w konsoli 

	Komendy SQL:
	Remove-Migration - usuwa migracje
	najpierw usuń migrację w katalogu migracje, zostać snapshota, potem wpisz
	add-migration AddCategoryTableToDb
	a potem
	update-database

	Ogarnąć sql żeby razem uzywać

	Tu mamy spis ikon które dodałem
	https://icons.getbootstrap.com
	Z tego linku wziąłem bootstrap ,,LUX''
	https://bootswatch.com

	Tag helper przy tworzeniu np guzików albo miejsc na wpisanie czegoś oda razu wie co ma być np int albo string
	<div class="mb-3 row p-1">
			<label asp-for="Name" class="p-0"></label>
			<input asp-for="Name" class="form-control" />
		</div>
		<div class="mb-3 row p-1">
			<label asp-for="DisplayOrder" class="p-0"></label>
			<input asp-for="DisplayOrder" class="form-control"/>
		</div>


		w Create.cshtml

		zamiast
		<form metod="Post">
		musi być
		<form metod="Post" asp-action="Create">
		ponieważ używamy tagów w asp .net i musimy pokazać nazwę metody która ma być w post