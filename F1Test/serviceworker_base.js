self.addEventListener('install', event => {
    console.log('installing');
});

self.addEventListener('activate', event => {
    console.log('activating');
});

self.addEventListener('fetch', event => {
    const url = new URL(event.request.url);

    if (url.origin == location.origin) {
        console.log('match:' + url);
    }
});