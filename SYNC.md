# GitHub Sync Cheat Sheet

## Check repo and remote
```bash
git remote -v
git status
```

- `origin` should point to your GitHub repo URL.[cite:107]
- `Your branch is up to date with 'origin/main'` means local and GitHub are synced.[cite:69][cite:116]
- `Untracked files` means the files exist locally but are not in Git yet.[cite:69][cite:79]

## Add only what you want
```bash
git add PracTask1_1 SwitchStatement
```

- This stages only those folders and leaves other files, like local `.md` notes, untracked.[cite:83][cite:88]

## Save and upload
```bash
git commit -m "Add Week 1 practical tasks"
git push
```

- `git commit` saves the staged changes as a snapshot.[cite:113]
- `git push` sends your local commits to `origin/main` on GitHub.[cite:45][cite:113]

## When you see these messages
- `ahead of 'origin/main'` -> run `git push`.[cite:112][cite:113]
- `behind 'origin/main'` -> run `git pull`.[cite:114][cite:116]
- `.md` files still showing as untracked -> leave them local or add them to `.gitignore`.[cite:102][cite:105]

## Typical SIT232 workflow
```bash
git status
git add <specific folders/files>
git commit -m "Describe the change"
git push
```

- Use this when you want to sync selected prac folders to GitHub without uploading everything in the repo folder.[cite:83][cite:113]
