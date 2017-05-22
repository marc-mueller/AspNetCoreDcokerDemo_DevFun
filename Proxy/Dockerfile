FROM nginx:latest

COPY nginx.conf /etc/nginx/nginx.conf
COPY default.conf /etc/nginx/conf.d/default.conf
COPY localcopassword.crt /etc/nginx/ssl/localcopassword.crt
COPY localcopassword.key /etc/nginx/ssl/localcopassword.key