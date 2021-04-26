const myLat = 49.73441135013576
const myLng = -123.13636253334089

function initMap() {
    map = new google.maps.Map( document.getElementById( 'map' ), {
        center: {
            lat: myLat,
            lng: myLng
        },
        zoom: 8,
        mapId: 'MAPSTYLE'
    } );
    
    new google.maps.Marker( {
        position: {
            lat: myLat,
            lng: myLng
        },
        map,
        title: "Hello World!",
    } );
    
}

 
