# Changelog

Wszystkie znaczące zmiany w tym projekcie są zapisywane w tym pliku.

Format zgodny z "Keep a Changelog" oraz semver: MAJOR.MINOR.PATCH
- Unreleased — zmiany, które są obecnie w development.
- Przy wydaniu przenieś wpisy z sekcji Unreleased do odpowiedniej wersji (z datą).

## [Unreleased]

### Added
- Dodaj tutaj nowe funkcje (np. `feat: ...`) i linki do PR/issue.

### Changed
- Zmiany zachowania API lub refaktory.

### Fixed
- Poprawki błędów.

## [0.2.0] - 2026-02-..
### Added
- Dodano nowe okno [Edycja Suwnicy]
- Wstępna inicjalizacja okna
- Dodano możliwość minimalizacji okien w aplikacji
- Dodano tabele DANE TECHNICZNE w Dźwignicach

### Changed
- Zmieniono całkowicie działanie przycisku [Edycja]
- Usunięto stary niepotrzebny kod
- Brak możliwości zmiany rozmiaru okna
- Zmieniono nazwę z DANE TECHNICZNE -> DANE IDENTYFIKACYJNE

### Fixed
- Kliknięcie Anuluj poprawnie zamyka okno, nie wywala aplikacji : drobna literówka
- Okno [Edycja Suwnic] poprawnie się wyświetla na środku (czasami znikało poza ramami ekranu)
- Edycja danych suwnicy poprawnie nadpisuje dane
- "Status" w oknie DANE UDT jest poprawnie wyświetlany obok TextBox'a
- Zmieniono rozmiar okna Dźwignice aby poprawnie wyświetlać przycisk powrót i tablice UDT
- TextBox Poducent wyświetla sie teraz prawidłowo (poprzednio nachodziło na TextBox wyżej)

## [0.1.1b] HOTFIX #1
### Fixed
- Poprawne wyświetlanie okien
- Blokada boxów w oknie dźwignic

---
## [0.1.0b] - 2026-02-05
### Added
- Dodano możliwość dodania nowej suwnicy
- Dodano okno w którym dodajemy suwnice
- Dodano logike zapisu i odczytu suwnic w polach
- Przejscie z Alpha na Beta

### Changed
- Wyłączono na chwilę obecną przycisk [Edycja]
- [ChceckBox Edycja] - wyłączony
- Przycisk [Dodaj] został na stałe włączony
- Brak możliwości zmiany danych w oknie dźwignic
- Chwilowo usunięto przycisk [Zapis] z okna suwnic

---
## [0.0.3a] - 2026-02-03
### Added
- Dodanie nowego przycisku w oknie dźwignic 'Powrót ->', 'Edycja', 'Zapisz'
- Dodano przykładowe okno autoryzacji

### Changed
- Box "Dane UTD" - Zmieniono obramowanie box'a

### Fixed
- Okno główne poprawnie się zamyka przy przejściu do nowego okna
- Usunięto błąd z przyciskami Powrót i Edycja - niepoprawne wyświetlanie i obługa zdarzeń
- Box "Dane UTD" jest już tylko do odczytu
- Okno autoryzacji poprawnie teraz wyświetla przycisk "ok" - poprzednio połowa znikała

---
## [0.0.2a] - 2026-01-12
### Added
- Dodano nowe okno po kliknięciu przycisku "Dźwignice".
- Dodano opcje wyboru ID dźwignicy z listy rozwijanej.
- Dodano CheckBox do aktywacji edycji poszczególnych pól.
- Dodano komentarze w kodzie dla lepszej czytelności.
- Dodano Dane techniczne dźwignic, w module "Dźwignice".
- Dodano Dane UDT w module "Dźwignice".
- Dodano przycisk "Dodaj" oraz "Usuń" w module "Dźwignice".
- ChceckBox'a trzeba aktywować aby można było edytować pola tekstowe.
	
### Changed
- Zmiany w kodzie obsługującym przyciski i pola tekstowe.
- Zmieniono układ CheckBox'a w module "Dźwignice".

### Fixed
- Poprawka nazwy okna z "Dzwignice" na "Dźwignice".

---
## [0.0.1a] - 2026-01-11
### Added
- Uaktualniono informacje o wersji do 0.0.1a (Alpha)
- Dodano informacje dla przycisków "Dźwignice", "Wózki jedzniowe" oraz "Inne".

### Changed
- Zmieniono nazwę strony głównej z "MainWindow" na "Pomocnik Dozorowy pre-alpha"
- Przycisk "Wyjście" działa i wyświetla komunikat o zamknięciu aplikacji.

### Fixed
- Poprawiono drobne błędy w interfejsie użytkownika.
- Poprawne wyświetlanie napisu "Informacje o programie", oraz przycisku "?".

---
## [0.0.0] - 2026-01-10
### Added
- Pierwsze wydanie projektu.

### Fixed
- N/A
