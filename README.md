<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Aplikacja do tworzenia i zarządzania kartami postaci</title>
</head>
<body>
    <h1>Aplikacja do tworzenia i zarządzania kartami postaci</h1>

    <p>Aplikacja służy do tworzenia i zarządzania kartami postaci przeznaczonymi głównie do gier planszowych, takich jak Dungeon & Dragons. Umożliwia graczom tworzenie i przeglądanie postaci, podczas gdy GameMaster może nimi zarządzać, dodając na przykład złoto lub inne elementy rozgrywki.</p>

    <h2>Wymagania</h2>

    <p>Aktualnie brak specyfikacji dotyczącej wymagań systemowych.</p>

    <h2>Konfiguracja</h2>

    <ol>
        <li>Sklonuj repozytorium na swoje urządzenie.</li>
        <li>Ustaw połączenie z bazą danych SQL. Możesz to zrobić, edytując plik <code>appsettings.json</code> w folderze <code>Game_Menager_Web</code>, w sekcji <code>ConnectionStrings</code>, zmieniając wartość klucza <code>"DeafaultConnection"</code>.</li>
        <li>Wykonaj migracje bazy danych za pomocą narzędzia konsoli Migrations w Visual Studio. Uruchom poniższe komendy:
            <pre><code>add-migration InitialCreate
update-database</code></pre>
        </li>
        <li>Uruchom aplikację.</li>
    </ol>

    <h2>Użycie</h2>

    <ol>
        <li>Po uruchomieniu aplikacji, użytkownicy mogą zarejestrować nowe konto lub zalogować się do istniejącego.</li>
        <li>Po zalogowaniu, gracze mogą tworzyć nowe karty postaci, edytować istniejące, przeglądać je i zarządzać nimi.</li>
        <li>GameMasterzy mają dodatkowe uprawnienia, które pozwalają im zarządzać postaciami graczy, np. dodając złoto lub inne przedmioty do ich ekwipunku.</li>
    </ol>

    <h2>Planowane Rozwinięcia</h2>

    <p>W przyszłości planowane jest dodanie kolejnych funkcji, w tym:</p>
    <ul>
        <li>Rozwinięcie dodawania broni i innych przedmiotów do ekwipunku postaci.</li>
        <li>Historia postaci, aby śledzić zmiany i wydarzenia z nią związane.</li>
        <li>Wskaźnik aktualnego zdrowia (HP) postaci względem jej pełnego zdrowia, np. otrzymywanie obrażeń.</li>
    </ul>

    <h2>Kontrybucja</h2>

    <p>Jeśli chcesz przyczynić się do rozwoju tej aplikacji, proszę zforkuj repozytorium, wprowadź swoje zmiany i wyślij pull request. Upewnij się, że opisujesz dokładnie swoje zmiany i ich cel, aby ułatwić proces review.</p>
</body>
</html>
