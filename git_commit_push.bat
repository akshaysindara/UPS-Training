@echo off
setlocal
title Git Stage, Commit, and Optional Push

REM Move to the directory where this .bat file is stored.
cd /d "%~dp0"

REM Confirm this is inside a Git repository.
git rev-parse --show-toplevel >nul 2>&1
if errorlevel 1 (
    echo ERROR: This folder is not inside a Git repository.
    echo Save this .bat file in your repository root, then run it again.
    pause
    exit /b 1
)

echo.
echo Repository:
git rev-parse --show-toplevel
echo.

REM Stage all non-ignored changes.
echo Staging changes...
git add .
if errorlevel 1 (
    echo ERROR: Could not stage changes.
    pause
    exit /b 1
)

echo.
git status --short
echo.

REM Ask for a commit message.
set "COMMIT_MSG="
set /p "COMMIT_MSG=Enter commit message: "
if not defined COMMIT_MSG (
    echo ERROR: Commit message cannot be empty.
    pause
    exit /b 1
)

REM Commit staged changes.
git commit -m "%COMMIT_MSG%"
if errorlevel 1 (
    echo.
    echo Commit failed. There may be no changes to commit, or Git reported an error.
    pause
    exit /b 1
)

echo.
set "PUSH_CHOICE="
set /p "PUSH_CHOICE=Push to GitHub now? (Y/N): "

if /I "%PUSH_CHOICE%"=="Y" (
    echo.
    git push
    if errorlevel 1 (
        echo.
        echo ERROR: Push failed. Review the message above.
        pause
        exit /b 1
    )
    echo.
    echo Push completed successfully.
) else (
    echo.
    echo Skipping push. Your commit is saved locally.
)

echo.
pause
endlocal
