Stworzyć do każdego Controllera front
	LogginController => View - Loggin
	HomeController => View - Index
	Category => zapas zobaczymy co będzie w kursie

	Migracja sql, stworzenie bazy

	odc 65

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

		<div asp-validation-summary="All"></div> wypisuje listę co musi być np hasło od 8 znaków itd


		W Index kartypostaci musimy zrobić tak że admin może edytować postaci a gracz otwierać kartę na cały ekran

		W sql dodać level

		poprawić w kartaPos te za ciemny kolor na zaklęciach

		Test@gmail.com
		Admin123*