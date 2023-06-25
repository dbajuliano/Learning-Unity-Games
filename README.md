# Learning-Unity-Games
Learning how to code

# Update
Study material from 2018

Repositories migrated to subfolders on 24-06-2023

# 04 Projects
Each per directory

# How was it migrated?

GitHub: moving repositories as a subfolder of another repository

Main repo: ```Learning-Unity-Game```

Other repos: ```Block-Breaker, NumberWizard, Text101, number-wizard-ui```

Move all other repos into the main repo:
1. Create an empty main repo on GitHub: ```Learning-Unity-Game```
2. Clone it to your machine: ```git clone https://github.com/dbajuliano/Learning-Unity-Game.git```
3. To merge any other existent repo into the main repo as a subfolder, run this command inside the main repo folder:

```git subtree add -P <prefix> <repo> <rev>```

```git subtree add -P Block-Breaker git@github.com:dbajuliano/Block-Breaker.git HEAD```

Note: Set ```<prefix>``` to the name of the subdirectory ```Block-Breaker```, ```<repo>``` to the clone URL of ```Block-Breaker```, and ```<rev>``` to the revision of ```Block-Breaker``` you want (```HEAD``` if latest)

This will take the history of the ```Block-Breaker``` repo and merge it with ```Learning-Unity-Game```, along with an additional merge commit.

4. Push the changes to GitHub.com

```git push -u origin main```


Repeat the process for any other repo to be merged.
