
# Naming Conventions
These are the GitHub naming conventions used within the project.

## For Branches
A branch name should start with a category

- feature is for adding/removing/changing a feature
- bugfix is for fixing a bug
- hotfix is for changing code with a temporary solution
- test is for experimenting
- docs is for adding/removing/changing documentation

Follow with a backlash and a reference number. If there is no reference number, put **'no-ref'**. Next, write a short hyphen separated description.

Example:
```
feature/no-ref/add-validateInt-function
```

## For Commits
A commit message should start with a category of change
- feat is for adding a new feature
- fix is for fixing a bug
- refactor is for changing code for performance or convenience purpose
- chore is for everything else (writing documentation, formatting, adding tests, cleaning useless code etc.)

Then add a colon (:) and a short imperative, present tense, ie "change" not "changed" nor "changes", then a brief message. You can also add a longer description as needed.

Example:

```
feat: add new integer validation function.
```
