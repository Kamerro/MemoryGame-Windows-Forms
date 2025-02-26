# Memory Game

## Overview
Memory Game is a C# WinForms application where players flip cards to find matching pairs. The game tracks the player's progress, enforces rules, and provides a simple user interface for interaction. It is built with an object-oriented approach, utilizing dependency injection for better scalability and maintainability.

## Features
- **Card Matching Mechanism**: Players flip two cards at a time to find matching pairs.
- **Game Timer**: A countdown timer limits the game duration.
- **Scoring System**: Tracks the player's progress and updates points dynamically.
- **Dependency Injection**: Uses Microsoft's Dependency Injection framework to manage services.
- **Shuffle Mechanism**: Ensures randomized card placements for each game session.
- **Game Reset**: Players can restart the game anytime.
- **Win/Loss Conditions**: The game ends when all pairs are found or when the timer runs out.

## Technologies Used
- **C# (.NET Framework)**
- **Windows Forms (WinForms)**
- **Microsoft.Extensions.DependencyInjection**
- **System.Drawing** (for Image Processing)

## Project Structure
```
MemoryGame/
│── Cards/
│   ├── Card.cs               # Represents a memory card with a front and back view.
│
│── Configuration/
│   ├── Config.cs             # Stores global game settings (e.g., image paths, dimensions, grid size).
│   ├── GameShelf.cs          # Manages game state, including active cards and score tracking.
│
│── Generators/
│   ├── CardGenerator.cs      # Generates and shuffles cards.
│   ├── ImageClickEventHandler.cs  # Handles user interactions with cards.
│
│── Services/
│   ├── ImageService.cs       # Handles image loading and resizing.
│   ├── CleanerService.cs     # Resets game state and UI elements.
│
│── Core Classes/
│   ├── GameInitializer.cs    # Initializes game components and resets parameters.
│   ├── MemoryGameService.cs  # Orchestrates game logic.
│   ├── TickService.cs        # Manages the game timer and card reveal delays.
│
│── UI/
│   ├── MemoGame.cs           # The main game window.
│   ├── MemoControls.cs       # Holds UI controls such as buttons, labels, and panels.
│
│── Program.cs                # Entry point of the application, setting up dependency injection.
```

## How to Run
1. Clone the repository.
2. Open the solution in **Visual Studio**.
3. Build and run the project.

## Areas for Improvement
- **Memory Management**: Optimize bitmap handling to prevent potential memory leaks.
- **Error Handling**: Improve exception handling in `Card.cs` to avoid application crashes.
- **Scalability**: Implement a more flexible grid layout to support different board sizes dynamically.
- **User Interface**: Enhance the UI with animations or graphical effects for a smoother experience.
- **Unit Tests**: Add unit tests for core game logic to ensure robustness.
- **Code Refactoring**: Extract some logic in `ImageClickEventHandler.cs` and `CardGenerator.cs` into smaller helper methods for better readability and maintainability.

## Contribution
Feel free to fork this repository and submit pull requests for enhancements and bug fixes!

